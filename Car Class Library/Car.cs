using System;
using System.ComponentModel.DataAnnotations;

namespace Car_Class_Library
{
    public class Car
    {
        public int Id { get; set; }
        private string _model { get; set; }
        private int _price { get; set; }
        private string _license { get; set; }

        private const int ModelMinLength = 4;
        private const int PriceMin = 0;
        private const int LicenseMin = 2;
        private const int LicenseMax = 7;

        public Car(int id, string model, int price, string license)
        {
            Id = id;
            Model = model;
            Price = price;
            License = license;
        }

        public Car()
        {
            
        }

        /// <summary>
        /// Model of a car
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">if model string length is not [4;inf[</exception>
        public string Model
        {
            get => _model;
            set
            {
                if (value == null) throw new ArgumentNullException(nameof(Model), "Model is null");
                if (value.Length < ModelMinLength) throw new ArgumentOutOfRangeException(nameof(Model), $"Model: '{value}' length must be (>{ModelMinLength})");
                _model = value;
            }
        }

        /// <summary>
        /// Price of a car
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">if price value is not ]0;inf[</exception>
        public int Price
        {
            get => _price;
            set
            {
                if (value <= PriceMin) throw new ArgumentOutOfRangeException(nameof(Price), $"Price: {value} out of range (>{PriceMin})");
                _price = value;
            }
        }

        /// <summary>
        /// License plate of a car
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">if license string length is not [2;7]</exception>
        public string License
        {
            get => _license;
            set
            {
                if (value == null) throw new ArgumentNullException(nameof(License), "License is null");
                if (value.Length is < LicenseMin or > LicenseMax) throw new ArgumentOutOfRangeException(nameof(License), $"License: '{value}' length must be [{LicenseMin};{LicenseMax}]");
                _license = value;
            }
        }

        public override string ToString()
        {
            return $"ID: {Id} - Model: {Model} - Price: {Price} - License: {License}";
        }
    }
}
