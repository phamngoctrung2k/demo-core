using System;
using System.ComponentModel.DataAnnotations;

namespace demo.Models
{
    public class Student
    {
        [Key]
        public string StudentID { get; set; }
        public string StudentName { get; set; }
        public string PhoneNumber { get; set; }

    }
}
//(Tạo đối tượng Person (PersonID (string) và PersonName(string))
//Tạo đối tượng Student (StudentID, StudentName, Address)
///Tạo đối tượng Employee (EmployeeID, EmployeeName, PhoneNumber)
//Tạo đối tượng Product (ProductID, ProductName, UnitPrice, Quantity)
//Xây dựng các chức năng CRUD (Create, Read, Update, Delete) với các đối tượng vừa tạo.
//Chỉnh sửa các view, hiển thị tên các thuộc tính và chức năng thành tiếng việt có dấu.
//Đẩy code lên github, comment ở phần nhận xét của sinh viên)