/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Address
    {
        public string Street { get; set; } //? significa que pode ser nulo ou = String.Empty
        public int Number { get; set; }
        public string Neighborhood { get; set; }
        public string ZipCode { get; set; }
        public string? Complement { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }


        public Address(string street, int number, string neighborhood, string zipCode, string? complement, string city, string state, string country)
        {
            this.Street = street;
            this.Number = number;
            this.Neighborhood = neighborhood;
            this.ZipCode = zipCode;
            this.Complement = complement;
            this.City = city;
            this.State = state;
            this.Country = country;
        }
        public void showinfo()
        {
            Console.WriteLine($"Endereço: {Street}, {Number}");
            Console.WriteLine($"Bairro: {Neighborhood}");
            Console.WriteLine($"CEP: {ZipCode}");
            if(Complement != null)
            {
                Console.WriteLine($"Complemento: {Complement}");
            }
            Console.WriteLine($"Cidade: {City}");
            Console.WriteLine($"Estado: {State}");
            Console.WriteLine($"País: {Country}");
        }
    }

}*/
