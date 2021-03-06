﻿using System;
using System.Windows.Forms;

namespace TravelExperts
{
    /*
     * Date: January 2019
     * Creator: Manish Sudani
     */

    public static class Validator
    {
        public static bool IsProvided(TextBox tb, string name)
        {
            // Assume input is provided
            bool result = true;
            // If input is not provided, send message for requirement
            if (tb.Text == "")
            {
                result = false;
                MessageBox.Show(name + " is required", "Data entry error");
                tb.Focus();
            }
            return result;
        }

        public static bool IsNonNegativeInt(TextBox tb, string name)
        {
            // Assume input is valid number
            bool result = true;
            // If input is not valid integer, send message for requirement
            int num;
            if (!Int32.TryParse(tb.Text, out num))
            {
                result = false;
                MessageBox.Show(name + " has to be a non-negative whole number", "Data entry error");
                tb.SelectAll();
                tb.Focus();
            }
            else
            {
                // If input is not positive, send message for requirement
                if (num < 0)
                {
                    result = false;
                    MessageBox.Show(name + " has to be a non-negative whole number", "Data entry error");
                    tb.SelectAll();
                    tb.Focus();
                }
            }
            return result;
        }

        public static bool IsNonNegativeMoney(TextBox tb, string name)
        {
            // Assume input is valid number
            bool result = true;
            decimal num;
            if (!decimal.TryParse(tb.Text, out num))
            {
                result = false;
                MessageBox.Show(name + " has to be a non-negative value", "Data entry error");
                tb.SelectAll();
                tb.Focus();
            }
            else if (num < 0)
            {
                result = false;
                MessageBox.Show(name + " has to be a non-negative value", "Data entry error");
                tb.SelectAll();
                tb.Focus();
            }
            return result;
        }
    }
}