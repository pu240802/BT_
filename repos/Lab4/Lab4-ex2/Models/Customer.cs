using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab4_ex2.Models
{
    public class Customer
    {
        public string CustomerId { get; set; }
        public string FullName { get; set; } 
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int Balance { get; set; }

    }
    public interface ICustomerRepository {
        IList<Customer> GetCustomer();

        Customer GetCustomer(string customerId);
        void UpdateCustomer(Customer cus);
        IList<Customer> SearchCustomer(string name);
        void DeleteCustomer(Customer cus);

    }
    public class CustomerRepository : ICustomerRepository
    {
        static readonly List<Customer> data = new List<Customer>()
        {
            new Customer() {CustomerId = "KH001",FullName ="Trịnh Văn Chung",Address="Tp.Hcm",Email="dungta.uit@gmail.com",Phone="0363419330",Balance=15200000},
                new Customer() {CustomerId = "KH002",FullName ="Nhật Phương",Address="Tp.Quảng Ngãi",Email="nhatphuong02@gmail.com",Phone="0363419330",Balance=17200000},
                new Customer() {CustomerId = "KH003",FullName ="Tấn Phú",Address="Tp.Hà Nội",Email="tanphu@gmail.com",Phone="0334429182",Balance=1700000},
                new Customer() {CustomerId = "KH004",FullName ="Hàn Phong",Address="Tp.Phú Yên",Email="hanphong@gmail.com",Phone="0909609397",Balance=18200000}
        };
public void DeleteCustomer(Customer cus)
        {
            data.Remove(cus);
        }

        public IList<Customer> GetCustomer()
        {
            return data;
        }

        public Customer GetCustomer(string customerId)
        {
            return data.FirstOrDefault(c => c.CustomerId.Equals(customerId));
        }

        public IList<Customer> SearchCustomer(string name)
        {
           return data.Where(c => c.FullName.EndsWith(name)).ToList();
        }

        public void UpdateCustomer(Customer cus)
        {
            var customer = data.FirstOrDefault(c => c.CustomerId.Equals(cus.CustomerId));
            //nếu có thì sửa thông tin
            if (customer != null)
            {
                customer.FullName = cus.FullName;
                customer.Address = cus.Address;
                customer.Email = cus.Email;
                customer.Phone = cus.Phone;
                customer.Balance = cus.Balance;
            }
        }
        public void AddCustomer(Customer cus)
        {
            data.Add(cus);
        }

        
    }

}