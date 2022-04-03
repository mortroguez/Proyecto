using Proyecto.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Calculator : Form
    {
        List<CalculatorGrid> calculatorHistory = new();
        private string currentOperation = "";
        public Calculator()
        {
            InitializeComponent();
        }

        // Disables parent's form to avoid opening more than one instance
        // of this form
        private void Calculator_Load(object sender, EventArgs e)
        {
            this.Owner.Enabled = false;
        }
        private void Calculator_Closing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Enabled = true;
        }

        private void btn_result_Click(object sender, EventArgs e)
        {
            // Checks if an operator was given
            if (!string.IsNullOrEmpty(currentOperation))
            {
                // Check if the two expressions were provided
                if (!string.IsNullOrEmpty(txt_expression_i.Text) && !string.IsNullOrEmpty(txt_expression_ii.Text))
                {
                    // Check if the provided expressions are digits
                    if (txt_expression_i.Text.All(char.IsDigit) && txt_expression_ii.Text.All(char.IsDigit))
                    {
                        int operationResult = 0;
                        string observation = "";
                        switch (currentOperation)
                        {
                            case "ADDITION":
                                operationResult = Convert.ToInt32(txt_expression_i.Text) + Convert.ToInt32(txt_expression_ii.Text);
                                break;
                            case "SUBSTRACTION":
                                operationResult = Convert.ToInt32(txt_expression_i.Text) - Convert.ToInt32(txt_expression_ii.Text);
                                break;
                            case "MULTIPLICATION":
                                operationResult = Convert.ToInt32(txt_expression_i.Text) * Convert.ToInt32(txt_expression_ii.Text);
                                break;
                            case "DIVISION":
                                    operationResult = Convert.ToInt32(txt_expression_i.Text) / Convert.ToInt32(txt_expression_ii.Text);
                                break;
                            default:
                                break;
                        }
                        if (!string.IsNullOrEmpty(observation))
                        {
                            // TODO: Write .txt
                        }
                        calculatorHistory.Add(new()
                        {
                            Expression1 = txt_expression_i.Text,
                            Operation = currentOperation,
                            Expression2 = txt_expression_ii.Text,
                            Observations = string.IsNullOrEmpty(observation) ? operationResult.ToString() : observation
                        });
                    }
                    else
                    {
                        // TODO: write .txt
                        calculatorHistory.Add(new()
                        {
                            Expression1 = txt_expression_i.Text,
                            Operation = currentOperation,
                            Expression2 = txt_expression_ii.Text,
                            Observations = "Lexical error"
                        });
                    }
                }
                else
                {
                    // TODO: write .txt
                    calculatorHistory.Add(new()
                    {
                        Expression1 = txt_expression_i.Text,
                        Operation = currentOperation,
                        Expression2 = txt_expression_ii.Text,
                        Observations = "Semantic error"
                    });
                }
            }
            else
            {
                // TODO: write .txt
                // TODO: write .txt
                calculatorHistory.Add(new()
                {
                    Expression1 = txt_expression_i.Text,
                    Operation = currentOperation,
                    Expression2 = txt_expression_ii.Text,
                    Observations = "Syntax error"
                });
            }
            dgv_main.DataSource = null;
            dgv_main.DataSource = calculatorHistory;
            dgv_main.Refresh();
        }

        private void btn_addition_Click(object sender, EventArgs e)
        {
            currentOperation = "ADDITION";
        }

        private void btn_subtraction_Click(object sender, EventArgs e)
        {
            currentOperation = "SUBSTRACTION";
        }

        private void btn_clear_all_Click(object sender, EventArgs e)
        {
            txt_expression_i.Text = string.Empty;
            txt_expression_ii.Text = string.Empty;
            currentOperation = string.Empty;
            calculatorHistory = new();
            dgv_main.DataSource = calculatorHistory;
            dgv_main.Refresh();
        }

        private void btn_multiplication_Click(object sender, EventArgs e)
        {
            currentOperation = "MULTIPLICATION";
        }

        private void btn_division_Click(object sender, EventArgs e)
        {
            currentOperation = "DIVISION";
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            currentOperation = string.Empty;
        }
    }
}
