using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AirlineMVC5.Models
{
    /// <summary>
    /// jonathan 
    /// </summary>
    public class Address
    {
        public int AddressID { get; set; }

        [DisplayName("House No"), Required]
        public String HouseNumber { get; set; }

        public String Street { get; set; }

        public String Town { get; set; }

        public Counties County { get; set; }

        public String PostCode { get; set; }

        // Navigation Properties

        //public virtual Customer Customer { get; set; }

    }

    public enum Counties
    {
        Bedfordshire,
        Berkshire,
        Bristol,
        Buckinghamshire,
        Cambridgeshire,
        Cheshire,
        Cornwall,
        CountyDurham,
        Cumberland,
        Derbyshire,
        Devon,
        Dorset,
        Essex,
        Gloucestershire,
        Hampshire,
        Herefordshire,
        Hertfordshire,
        Huntingdonshire,
        Kent,
        Lancashire,
        Leicestershire,
        Lincolnshire,
        Middlesex,
        Norfolk,
        Northamptonshire,
        Northumberland,
        Nottinghamshire,
        Oxfordshire,
        Rutland,
        Shropshire,
        Somerset,
        Staffordshire,
        Suffolk,
        Surrey,
        Sussex,
        Warwickshire,
        Wiltshire,
        Worcestershire,
        Yorkshire
    }
}

