//K1773
//Program 4 
//12-1-20
//CIS 199-02
//Program that uses service order objects to create an array of objects and output each property of them

using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace Program_4
{
    class ServiceOrder
    {
        private const int defaultZip = 40204;                       //variable for the default zip code if entered number does not pass validation
        private const int minZip = 00000;                           //minimum number accepted for zip code entry
        private const int maxZip = 99999;                           //maximum number accepted for zip code entry
        private const int minAppLength = 15;                        //minimum number accepted for appointment length entry
        private const int maxAppLength = 180;                       //maximum number accepted for appointment length entry
        private const int defaultAppLength = 30;                    //default appointment length if entry does not pass validation
        private const int modelLength = 5;                          //int used for validating model number string length
        private const int serialLength = 10;                        //int used for validating serial number string length
        private const string defaultModel = "A1234";                //default model number if entry does not pass validation
        private const string defaultSerial = "C123456789";          //default serial number if entry does not pass validation
        private const string defaultTechName = "John Smith";        //default technician name if entry does not pass validation
        private const int flatFee = 25;                             //flat fee used in calculating cost of job
        private const double minuteFee = 1.50;                      //cost per minute used in calculating cost of job
        private const double defaultCost = 20.0;                    //default cost if entry has warranty
        private const double minToHours = 60.0;

        private int _serviceLocationZipCode;                //int for zip code property of object
        private int _appointLength;                         //int for appointment length property of object
        private string _modelNumber;                        //string for model number property of object
        private string _serialNumber;                       //string for serial number property of object
        private string _technicianName;                     //string for the technician name property of object
        private bool _warrantyCoverage;                     //bool for warranty coverage property of object
        private double _cost;                               //double for cost property of object
        private double _appointmentHours;                   //double for appointment length in hours property of object

        public int ServiceLocationZipCode
        {
            set 
            {
                if (value >= minZip && value <= maxZip)     //tests if entered zip is within min and max of int constants
                {
                    _serviceLocationZipCode = value;        //assigns zip property to entered value
                }
                else
                {
                    _serviceLocationZipCode = defaultZip;   //assigns zip property to default value if not within range
                }
            }
            get
            {
                return _serviceLocationZipCode;             //returns zip property 
            }
        }
        public int AppointLength
        {
            set
            {
                if (value >= minAppLength && value <= maxAppLength)     //tests if entered appointment length is within min and max of int constants 
                {
                    _appointLength = value;                 //assings appointment length property to entered value
                }
                else
                {
                    _appointLength = defaultAppLength;      //assigns appointment length property to default value if entered value did not pass validation
                }
            }
            get
            {
                return _appointLength;                      //returns appointment length property
            }
        }
        public string ModelNumber
        {
            set
            {
                if (value.Length == modelLength)            //checks if entered model number has the correct number of characters
                {
                    _modelNumber = value;                   //assigns model number property to entered value
                }
                else 
                {
                    _modelNumber = defaultModel;            //assigns model number property to default value if validation isn't passed
                }
            }
            get
            {
                return _modelNumber;                        //returns model number
            }
        }
        public string SerialNumber
        {
            set
            {
                if (value.Length == serialLength)           //tests if serial number is the correct length 
                {
                    _serialNumber = value;                  //assigns serial number proerty to entered value
                }
                else
                {
                    _serialNumber = defaultSerial;          //assigns serial number prorerty to default value if validation isn't passed
                }
            }
            get
            {
                return _serialNumber;                       //returns serial number property
            }
        }
        public string TechnicianName
        {
            set
            {
                if (!String.IsNullOrEmpty(value))           //tests if anything is entered for technician name 
                {
                    _technicianName = value;                //assigns technician name property to entered value
                }
                else
                {
                    _technicianName = defaultTechName;      //assigns technician name property to default value if validation isn't passed
                }
            }
            get
            {
                return _technicianName;                     //returns technitian name
            }
        }
        public bool WarrantyCoverage
        {
            set
            {
                _warrantyCoverage = value;      //assigns entered value to waranty coverage bool porperty 
            }
            get
            {
                return _warrantyCoverage;       //returns warranty coverage property
            }
        }
        public double Cost 
        {
            get 
            {
                return CalcCost();          //returns cost property by calling CalcCost method
            }
        }
        public double AppointmentHours 
        {
            get 
            {
                _appointmentHours = _appointLength / minToHours;            //coverts appointment length from minutes to hours      
                return _appointmentHours;                                   //returns appointment length in hours
            }
        }
        public ServiceOrder(int serviceLocationZipCode, string modelNumber, string serialNumber, int appointLength, string technicianName, bool warrantyCoverage)       //declares service order costructor
        {
            ServiceLocationZipCode = serviceLocationZipCode;                    //assings zip code int to entered zip code int
            ModelNumber = modelNumber;                                          //assings model number string to entered model number string
            SerialNumber = serialNumber;                                        //assings serial number string to entered serial number string
            AppointLength = appointLength;                                      //assings appointment length int to entered appointment length int
            TechnicianName = technicianName;                                    //assings technician name string to entered technician name string
            WarrantyCoverage = warrantyCoverage;                                //assings warranty coverage bool to entered warranty coverage bool
        }
        public double CalcCost()                        //declaring CalcCost method 
        {
            if (_warrantyCoverage)                      //test if object has warranty coveravge 
            {
                _cost = defaultCost;                    //sets cost to default value
            }
            else 
            {
                _cost = flatFee + (minuteFee * _appointLength);     //calculates cost based on appoitment legth and flat fee
            }
            return _cost;                   //returns cost property
            
        }
        public override string ToString()           //declaring tostring method to override default method
        {
            return "Service Location Zip Code:  " + ServiceLocationZipCode          //outputting each property with according labels
                + "\nModel Number:  " + ModelNumber
                + "\nSerial Number:  " + SerialNumber
                + "\nAppointment Length:  " + AppointLength
                + "\nTechnician Name:  " + TechnicianName
                + "\nWarranty Coverage?:  " + WarrantyCoverage
                + "\nCalculate Cost Output:  " + Cost.ToString("C3", CultureInfo.CurrentCulture);

        }
    }
}
