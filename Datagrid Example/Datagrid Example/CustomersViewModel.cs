using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Windows.Data;

namespace DataGrid
{
    public class CustomerViewModel
    {
        public ICollectionView Customers { get; private set; }
        public ICollectionView GroupedCustomers { get; private set; }

        public CustomerViewModel()
        {
            var _customers = new List<Customer>
                                 {
                                     new Customer
                                         {
                                             FirstName = "Christian",
                                             LastName = "Moser",
                                             Gender = Gender.Male,
                                             WebSite = new Uri("http://www.wpftutorial.net"),
                                             ReceiveNewsletter = true,
                                             Image = "Images/An.J.jpg",
                                             CarsOwned=  new List<Car>{ 
                                                                        new Car(){ID=1, MakeName="Toyota", Picture="", registrationPlate = "1A2S5WED"}, 
                                                                        new Car(){ID=2, MakeName="Ferrari", Picture="", registrationPlate="ER7DFD51S"}
                                                                      }
                                         },
                                     new Customer
                                         {
                                             FirstName = "Peter",
                                             LastName = "Meyer",
                                             Gender = Gender.Male,
                                             WebSite = new Uri("http://www.petermeyer.com"),
                                             Image = "Images/MariahCarey_070913.jpg"
                                         },
                                     new Customer
                                         {
                                             FirstName = "Lisa",
                                             LastName = "Simpson",
                                             Gender = Gender.Female,
                                             WebSite = new Uri("http://www.thesimpsons.com"),
                                             Image = "Images/Michael-Ochs-Archive-Photos-michael-jackson-31834608-1140-1422.jpg"
                                         },
                                     new Customer
                                         {
                                             FirstName = "Betty",
                                             LastName = "Bossy",
                                             Gender = Gender.Female,
                                             WebSite = new Uri("http://www.bettybossy.ch"),
                                             Image = "Images/bob.jpg"
                                         }
                                 };

            Customers = CollectionViewSource.GetDefaultView(_customers);

            GroupedCustomers = new ListCollectionView(_customers);
            GroupedCustomers.GroupDescriptions.Add(new PropertyGroupDescription("Gender"));
        }
    }
}
