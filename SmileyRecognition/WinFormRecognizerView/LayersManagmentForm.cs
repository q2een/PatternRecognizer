using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PatternRecognizer.BL.Network; 

namespace PatternRecognizer
{
    public partial class LayersManagmentForm : Form
    {           
        public int NeuronsCount => decimal.ToInt32(numNeuronsCount.Value);

        public string ActivationName => cmbActivations.SelectedValue.ToString();

        public LayerConfiguration LayerConfiguration
        {
            get => new LayerConfiguration(NeuronsCount, ActivationName);
            set
            {
                numNeuronsCount.Value = value.NeuronCount;
                cmbActivations.SelectedItem = value.OutputActivationName;
            }
        }

        public LayersManagmentForm(IEnumerable<string> activations, bool isFirstLayer = false)
        {
            InitializeComponent();

            cmbActivations.DataSource = activations; 
            numNeuronsCount.Enabled = !isFirstLayer;
        }

        private void CloseDialog_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
