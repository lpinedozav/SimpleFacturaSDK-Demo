﻿using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using SimpleFacturaSDK_Demo.Models;

namespace SimpleFacturaSDK_Demo.Helpers
{
    public static class EnumHelper
    {
        /// <summary>
        /// Llena un ComboBox con los valores de un enum.
        /// </summary>
        /// <typeparam name="T">Tipo de enum.</typeparam>
        /// <param name="comboBox">ComboBox a llenar.</param>
        public static void LlenarComboBoxConEnum<T>(ComboBox comboBox, Func<T, bool> filtro = null) where T : Enum
        {
            // Obtén todos los valores del enum
            var enumValues = Enum.GetValues(typeof(T)).Cast<T>();

            // Aplica el filtro si se proporciona
            if (filtro != null)
            {
                enumValues = enumValues.Where(filtro);
            }

            // Limpia los elementos existentes
            comboBox.Items.Clear();

            // Agrega los elementos filtrados al ComboBox
            foreach (var value in enumValues)
            {
                string descripcion = ObtenerDescripcion(value);
                comboBox.Items.Add(new ComboBoxItem { Text = descripcion, Value = value });
            }

            // Selecciona el primer elemento si hay al menos uno
            if (comboBox.Items.Count > 0)
            {
                comboBox.SelectedIndex = 0;
            }
        }


        /// <summary>
        /// Obtiene la descripción del atributo Description de un valor de enum.
        /// </summary>
        /// <param name="value">Valor del enum.</param>
        /// <returns>Descripción o nombre del valor del enum.</returns>
        public static string ObtenerDescripcion(Enum value)
        {
            FieldInfo field = value.GetType().GetField(value.ToString());
            DescriptionAttribute attribute = field?.GetCustomAttribute<DescriptionAttribute>();
            return attribute?.Description ?? value.ToString();
        }

        /// <summary>
        /// Obtiene el valor seleccionado de un ComboBox.
        /// </summary>
        /// <typeparam name="T">Tipo de enum.</typeparam>
        /// <param name="comboBox">ComboBox que contiene los valores.</param>
        /// <returns>Valor seleccionado del tipo T.</returns>
        public static T ObtenerValorSeleccionado<T>(ComboBox comboBox) where T : Enum
        {
            if (comboBox.SelectedItem is ComboBoxItem selectedItem)
            {
                return (T)selectedItem.Value;
            }

            throw new InvalidOperationException("No se ha seleccionado un valor válido.");
        }
    }
}
