// INFORMATION----------------------------------------------------------------------------
// DEVELOPER:        Anthony Harris
// GITHUB:           https://github.com/KillerBOB999/PerceptronLearningVisualizer
// DATE:             11 February 2020
// PURPOSE:          Perceptron Learning Visualizer tool in C# for CSC736: Machine Learning.
//----------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PerceptronLearningVisualizer
{
    public partial class Form1 : Form
    {
        // INITIALIZE THE FORM

        public Form1()
        {
            InitializeComponent();
        }

        //----------------------------------------------------------------

        // EVENT LISTENERS

        // Start the main application when the run button is clicked
        private void button_Run_Click(object sender, EventArgs e)
        {
            button_Run.Enabled = false;
            button_PlayPause.Enabled = true;
            button_Reset.Enabled = true;
            ChangeInputStates();
            StartSimulation();
        }

        // Reset the main application when the reset button is clicked
        private void button_Reset_Click(object sender, EventArgs e)
        {
            if (timer != null)
            {
                timer.Dispose();
                timer.Stop();
            }
            if (bitmap != null)
            {
                bitmap.Dispose();
            }
            points.Clear();
            WB.Clear();
            button_Reset.Enabled = false;
            using (Graphics graphics = splitContainer1.Panel2.CreateGraphics())
            {
                graphics.Clear(Color.Silver);
            }
            ChangeInputStates();
            button_PlayPause.Enabled = false;
            button_PlayPause.Text = "Pause Simulation";
            output_NumMisclassified.Text = "N/A";
            button_Run.Enabled = true;
        }

        // Automatically update and render the graph
        private void Timer_Tick(object sender, EventArgs e)
        {
            try
            {
                Update();
                Render();
            }
            catch
            {
                // Handle unknown errors gracefully
                timer.Enabled = false;
                MessageBox.Show("Oops, something went wrong!", "ERROR");
                button_Reset.PerformClick();
            }
        }

        // Validate input on input
        private void textBox_TextChanged(object sender, EventArgs e)
        {
            // CHECK FOR EMPTY INPUT
            if ((sender as TextBox).Text.Count() == 0) return;

            // CHECK FOR TOO MUCH INPUT
            else if ((sender as TextBox).Text.Length >= 12)
            {
                MessageBox.Show("Maximum input characters reached!", "MAX CHARACTERS");
                (sender as TextBox).Text = (sender as TextBox).Text.Remove((sender as TextBox).Text.Count() - 1);
            }
        }

        // Validate input upon completion
        private void textBoxDoubleCheck(object sender, EventArgs e)
        {
            double result;
            string name = (sender as TextBox).Name;

            // CHECK FOR INVALID INPUT
            if (!double.TryParse((sender as TextBox).Text, out result))
            {
                if ((sender as TextBox).Text == "")
                {
                    MessageBox.Show("No entry detected!\n\nPlease enter a valid number.",
                    "NO ENTRY");
                }
                else
                {
                    MessageBox.Show("\"" + (sender as TextBox).Text + "\" is not a valid entry.\nPlease enter a valid number.",
                    "INVALID ENTRY");
                    (sender as TextBox).Text = (sender as TextBox).Text.Remove(0);
                }
                (sender as TextBox).Focus();
            }

            // DO UNIQUE ACTIONS FOR OUT OF BOUNDS EVENTS
            else if (name == "input_r" || name == "input_n" || name == "input_p" || name == "input_e")
            {
                if ((name == "input_r") && (result > 0.001 || result < 0.0000000001))
                {
                    MessageBox.Show("Input out of bounds!\n\n" +
                        "The learning rate must be between 0.0000000001 and 0.001.",
                        "INPUT OUT OF BOUNDS");
                    (sender as TextBox).Text = (sender as TextBox).Text.Remove(0);
                    (sender as TextBox).Focus();
                }
                else if ((name == "input_n") && (result > 0.3 || result < 0))
                {
                    MessageBox.Show("Input out of bounds!\n\n" +
                        "The noise level must be between 0 and 0.3.",
                        "INPUT OUT OF BOUNDS");
                    (sender as TextBox).Text = (sender as TextBox).Text.Remove(0);
                    (sender as TextBox).Focus();
                }
                else if (name == "input_e" || name == "input_p")
                {
                    (sender as TextBox).Text = ((int)Convert.ToDouble((sender as TextBox).Text)).ToString();
                    if (Convert.ToInt32((sender as TextBox).Text) > 250 || Convert.ToInt32((sender as TextBox).Text) <= 0)
                    {
                        MessageBox.Show("Input out of bounds!\n\n" +
                        "The number of generated points and points per epoch must be between 1 and 250.",
                        "INPUT OUT OF BOUNDS");
                        (sender as TextBox).Text = (sender as TextBox).Text.Remove(0);
                        (sender as TextBox).Focus();
                    }
                    else  if (name == "input_e" && result > Convert.ToDouble(input_p.Text))
                    {
                        MessageBox.Show("Points per epoch must be less than or equal to generated points!\n\n",
                            "PPE <= GP");
                        (sender as TextBox).Text = (sender as TextBox).Text.Remove(0);
                        (sender as TextBox).Focus();
                    }
                    else if (name == "input_p" && Convert.ToDouble((sender as TextBox).Text) < Convert.ToDouble(input_e.Text))
                    {
                        input_e.Text = (sender as TextBox).Text;
                    }
                }
            }

            // CHECK FOR OUT OF BOUNDS
            else if ((name == "input_w" || name == "input_b") && (result > 25 || result < -25))
            {
                MessageBox.Show("Input out of bounds!\n\n" +
                    "The slope and y-intercept must each be between -25 and 25.",
                    "INPUT OUT OF BOUNDS");
                (sender as TextBox).Text = (sender as TextBox).Text.Remove(0);
                (sender as TextBox).Focus();
            }
        }

        // Start/stop the simulation when the pause/resume button is clicked
        private void button_PlayPause_Click(object sender, EventArgs e)
        {
            if (timer.Enabled) button_PlayPause.Text = "Resume Simulation";
            else button_PlayPause.Text = "Pause Simulation";
            timer.Enabled = !timer.Enabled;
        }

        //----------------------------------------------------------------

        // GLOBALS

        public double w = 0;    // SLope of the line (weight)
        public double b = 0;    // Y-intercept of the line (bias)
        public List<double> WB = new List<double>();// Calculated weights and bias
        public double wCalc = 0;// Calculated weight sum
        public double r = 0;    // Leanrning rate
        public int p = 0;       // Number of points generated
        public int e = 0;       // Number of points to train on per epoch
        public int width = 0;   // User determined width of the canvas
        public int height = 0;  // User determined height of the canvas

        public int epoch;       // Simple counter
        public int wrong = 0;   // Number of misclassified points

        // Generated points where x and y are random and the bool is true if y at x > CalcY(x, true)
        public List<Tuple<double, double, int>> points = new List<Tuple<double, double, int>>();
        public List<int> mislabels = new List<int>();

        public Timer timer;     // Used to auto update and render
        public Bitmap bitmap;   // Buffer for drawing to panel
        public const int roundTo = 5;   // Max precision


        //----------------------------------------------------------------

        // STARTING POINT OF THE MAIN APPLICATION

        public void StartSimulation()
        {
            try
            {
                CollectData();
                GeneratePoints();
                GenerateValues();
                bitmap = new Bitmap(width, height);
                epoch = 0;
                Render();
                SetUpTimer();
            }
            catch
            {
                MessageBox.Show("Oops, something went wrong!", "ERROR");
                button_Reset.PerformClick();
            }
        }

        //----------------------------------------------------------------

        // SET UP AND HELPER FUNCTIONS

        public void SetUpTimer()
        {
            timer = new Timer();
            timer.Tick += Timer_Tick;
            timer.Interval = 1; // Set interval to 0.5 seconds
            timer.Start();
        }

        public void CollectData()
        {
            w = Convert.ToDouble(input_w.Text);
            b = Convert.ToDouble(input_b.Text);
            r = Convert.ToDouble(input_r.Text);
            p = Convert.ToInt32(input_p.Text);
            e = Convert.ToInt32(input_e.Text);
            width = Convert.ToInt32(label_width.Text);
            height = Convert.ToInt32(label_height.Text);
        }

        private void ChangeInputStates()
        {
            input_w.Enabled = !input_w.Enabled;
            input_b.Enabled = !input_b.Enabled;
            input_p.Enabled = !input_p.Enabled;
            input_r.Enabled = !input_r.Enabled;
            input_e.Enabled = !input_e.Enabled;
        }

        //----------------------------------------------------------------

        // GENERATE THE NOISE

        public void GeneratePoints()
        {
            Random rng = new Random();
            for (int i = 0; i < p; ++i)
            {
                double generatedX = rng.Next(-width / 2, width / 2);     // Make a x
                double generatedY = rng.Next(-height / 2, height / 2);   // Make a y
                int classification;
                if (CalcY(generatedX, true) < generatedY) classification = 1;
                else classification = -1;
                points.Add(new Tuple<double, double, int>(
                    generatedX, 
                    generatedY, 
                    classification));
            }
        }

        public void GenerateValues()
        {
            Random rng = new Random();
            WB.Add(0); // Initialize the bias to 0
            foreach (var point in points)
            {
                WB.Add(rng.NextDouble());
            }
        }

        //----------------------------------------------------------------

        // HELPER FUNCTIONS

        // Calculate the Y value from the function
        public double CalcY(double x, bool isGroundTruth)
        {
            if (isGroundTruth) return w * x + b;
            else
            {
                return wCalc * x + WB[0];
            }
        }

        //----------------------------------------------------------------

        // UPDATE FUNCTIONS

        // Activation function. Determines output of neuron.
        public int activate(double sum)
        {
            return sum >= 0 ? 1 : -1;
        }

        // Feedforward function propogates the inputs throughout the network.
        public int feedForward(ref int index)
        {
            double sum;

            if (index > 0) sum = points[index - 1].Item1 * WB[index];
            else sum = WB[0];

            return activate(sum);
        }

        // Train the weights and bias
        public void train(ref int i)
        {
            int output = feedForward(ref i);
            if (i > 0)
            {
                if (points[i - 1].Item3 != output)
                {
                    ++wrong;
                    mislabels.Add(i);
                    System.Diagnostics.Debug.WriteLine("Misclassified Point:\n\tx = " + points[i - 1].Item1 + "\n\ty = " + points[i - 1].Item2
                        + "\n\tActual = " + points[i - 1].Item3 + "\n\tCalculated = " + output);
                    WB[i] += r * (points[i - 1].Item3 - output) * points[i - 1].Item1;
                }
            }
        }

        public void updateW()
        {
            wCalc = 0;
            for (int i = 0; i < points.Count(); ++i)
            {
                wCalc += points[i].Item1 * WB[i + 1];
            }
        }

        //----------------------------------------------------------------

        // RENDER FUNCTIONS

        // Draw the x and y axis, as well as the labels
        public void DrawAxis(Graphics graphics)
        {
            int centerX = width / 2;
            int centerY = height / 2;
            int maxX = 2 * centerX;
            int maxY = 2 * centerY;
            Point [] xTri = new Point[] { // Arrow vertices for x axis
                new Point(maxX, centerY), 
                new Point(maxX - 10, centerY + 10),
                new Point(maxX - 10, centerY - 10),
            };
            Point[] yTri = new Point[] { // Arrow vertices for y axis
                new Point(centerX, 0),
                new Point(centerX - 10, 10),
                new Point(centerX + 10, 10),
            };
            Pen pen = new Pen(Color.Black);
            Font font = new Font("Arial", 16);
            SolidBrush brush = new SolidBrush(Color.Black);

            graphics.DrawLine(pen, centerX, 0, centerX, maxY); // x axis
            graphics.DrawLine(pen, 0, centerY, maxX, centerY); // y axis

            graphics.DrawString("X", font, brush, maxX - 10 - font.Size, centerY + 10); // x label
            graphics.DrawString("Y", font, brush, centerX + 10, 0); //  y label

            graphics.FillPolygon(brush, xTri); // x arrow
            graphics.FillPolygon(brush, yTri); // y arrow

            using (font = new Font("Arial", 8))
            {
                for (float percentile = 0.05f; percentile < 1.0; percentile += 0.05f)
                {
                    int tempValue;
                    // Add lines to x axis
                    graphics.DrawLine(pen, percentile * width, centerY - 5, percentile * width, centerY + 5);
                    // Add labels to the lines
                    tempValue = Convert.ToInt32((percentile * width - width / 2));
                    if (tempValue != 0) graphics.DrawString(tempValue.ToString(), font, brush, percentile * width - tempValue.ToString().Length * font.Size / 2, centerY + 10);
                    // Add lines to y axis
                    graphics.DrawLine(pen, centerX - 5, percentile * height, centerX + 5, percentile * height);
                    // Add labels to the lines
                    tempValue = Convert.ToInt32(-1 * (percentile * height - height / 2));
                    if (tempValue != 0) graphics.DrawString(tempValue.ToString(), font, brush, centerX + 10, percentile * height - 0.5f * font.Height);
                }
            }
        }

        // Draw the function to the panel
        public void DrawLine(Graphics graphics, bool isGroundTruth)
        {
            float x1 = 0;
            float x2 = width;
            float lineWidth = 2;
            Pen pen;

            // Some helpers to transform graph to allow for all 4 quadrants
            float xConversion = width / 2;
            float yConversion = height / 2;

            // Which function are we trying to draw?
            if (isGroundTruth) pen = new Pen(Color.Lime, lineWidth);
            else pen = new Pen(Color.Yellow, lineWidth);

            graphics.DrawLine(pen, 
                x1, height - (float)CalcY(x1 - xConversion, isGroundTruth) - yConversion, 
                x2, height - (float)CalcY(x2 - xConversion, isGroundTruth) - yConversion);
        }

        // Draw the generated training points
        public void DrawPoints(Graphics graphics)
        {
            float radius = 4;

            // Some helpers to transform graph to allow for all 4 quadrants
            float xConversion = width / 2;
            float yConversion = height / 2;

            Color color;

            for (int i = 0; i < points.Count(); ++i)
            {
                color = mislabels.Contains(i) ? Color.Red : Color.Black;
                if (points[i].Item3 == 1) graphics.FillEllipse(new SolidBrush(color), 
                    (float)points[i].Item1 - radius + xConversion, // X-coord of center
                    height - (float)points[i].Item2 - radius - yConversion, // Y-coord of center
                    radius * 2, // Width
                    radius * 2);// Height
                else graphics.DrawEllipse(new Pen(color),
                    (float)points[i].Item1 - radius + xConversion, // X-coord of center
                    height - (float)points[i].Item2 - radius - yConversion, // Y-coord of center
                    radius * 2, // Width
                    radius * 2);// Height
            }
        }

        //----------------------------------------------------------------

        // UPDATE AND RENDER

        public void Update()
        {
            // Update base data
            ++epoch;
            wrong = 0;
            mislabels.Clear();

            // Update output of base data
            output_Epoch.Text = epoch.ToString();
            output_OldCalculatedLine.Text = "y = " + Math.Round(wCalc, roundTo).ToString()
                + " * x + " + Math.Round(WB[0], roundTo).ToString(); 

            // Update calculated weight and bias
            for (int i = 0; i < WB.Count(); ++i) train(ref i);

            // Update wCalc
            updateW();

            // Update output of the calculated line
            output_NewCalculatedLine.Text = "y = " + Math.Round(wCalc, roundTo).ToString()
                + " * x + " + Math.Round(WB[0], roundTo).ToString();
            output_NumMisclassified.Text = wrong.ToString();

            // Check to see if it's converged and stop it if so
            if (wrong == 0) button_PlayPause.PerformClick();
        }

        public void Render()
        {
            // Draw the desired image to a bitmap that will then replace
            // with the existing image in the panel. Doing this in this
            // manner is necessary to prevent flickering because the
            // SplitContainer.Panel2 object cannot be double buffered.
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                // Draw the background
                graphics.FillRectangle(new System.Drawing.SolidBrush(Color.LightGray),
                    0, 0, width, height);

                DrawAxis(graphics);         // Draw the x and y axis
                DrawLine(graphics, true);   // Draw ground truth line
                DrawLine(graphics, false);  // Draw calculated line
                DrawPoints(graphics);       // Draw generated points
            }

            // Draw the newly created bitmap to the screen
            using (Graphics graphics = splitContainer1.Panel2.CreateGraphics())
            {
                Bitmap sizedBitmap = new Bitmap(splitContainer1.Panel2.Width, splitContainer1.Panel2.Height);
                using (Graphics resizer = Graphics.FromImage(sizedBitmap))
                {
                    resizer.DrawImage(bitmap, 0, 0, splitContainer1.Panel2.Width, splitContainer1.Panel2.Height);
                }
                graphics.DrawImage(sizedBitmap, 0, 0);
            }
        }
    }
}
