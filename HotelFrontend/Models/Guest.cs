namespace HotelFrontend
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Guest : INotifyPropertyChanged
    {
        public int Guest_No { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }
        public virtual ICollection<Booking> Booking { get; set; }
        public Guest()
        {
            Booking = new HashSet<Booking>();
        }

        public Guest(string name, string address)
        {
            this.Name = name;
            this.Address = address;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public override string ToString()
        {
            return Name + " " + Address;
        }
    }
}
