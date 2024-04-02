using Microsoft.ML;
using System.Xml.Linq;

namespace Assignment3OOPMMRIGHTONE
{
    public partial class Form1 : Form
    {
        private MLContext mlContext;
        string originalModelPath = @"C:\\Users\\Matt\\source\\repos\\Assignment3OOPMMRIGHTONE\\Assignment3OOPMMRIGHTONE\\MLModel1.mbconfig";
        string retrainedModelPath = @"C:\\Users\\Matt\\source\\repos\\Assignment3OOPMMRIGHTONE\\Assignment3OOPMMRIGHTONE\\RetrainedMLModel1.zip";


        private ITransformer originalModel;
        private ITransformer retrainedModel;



        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GuessNumLabel_Click(object sender, EventArgs e)
        {

        }

        private void PredictButton_Click(object sender, EventArgs e)
        {
            //Load sample data
            var sampleData = new MLModel1.ModelInput()
            {
                Col0 = FeedbackTextBox.Text,
            };

            //Load model and predict output
            var result = MLModel1.Predict(sampleData);


            GuessNumLabel.Text = result.PredictedLabel.ToString();
            ConfidenceNumLabel.Text = (result.Score[0] * 100).ToString() + "%";
        }//End handler

        private void ReTrainButton_Click(object sender, EventArgs e)
        {
            {
                MLContext mlContext = new MLContext();
                
                    float dropDownSentimentValue = float.Parse(RetrainComboBox.Text);

                    var userInputData = new List<MLModel1.ModelInput>
                {
                    new MLModel1.ModelInput
                    {
                        Col0 = FeedbackTextBox.Text,
                        Col1 = dropDownSentimentValue
                    }
                };

                    var dataView = mlContext.Data.LoadFromEnumerable(userInputData);

                    //Retrain the model
                    ITransformer retrainedModel1 = MLModel1.RetrainPipeline(mlContext, dataView);


                    //Save the model
                    MLModel1.SaveModel(mlContext, retrainedModel1, dataView, retrainedModelPath);

                    MessageBox.Show("Model retrained and saved successfully at " + retrainedModelPath);

                
            }
        }
    }
}