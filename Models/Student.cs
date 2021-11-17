using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace demo.Models
{
    
    public class Student : Person
    {
        public string University { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

    }
}






//(Tạo đối tượng Person (PersonID (string) và PersonName(string))
//Tạo đối tượng Student (StudentID, StudentName, Address)
///Tạo đối tượng Employee (EmployeeID, EmployeeName, PhoneNumber)
//Tạo đối tượng Product (ProductID, ProductName, UnitPrice, Quantity)
//Xây dựng các chức năng CRUD (Create, Read, Update, Delete) với các đối tượng vừa tạo.
//Chỉnh sửa các view, hiển thị tên các thuộc tính và chức năng thành tiếng việt có dấu.
//Đẩy code lên github, comment ở phần nhận xét của sinh viên)