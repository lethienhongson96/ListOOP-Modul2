using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text;

namespace StudentManagement_LinkedList
{
    class Student : IComparable<Student>, IFormattable, IEquatable<Student>
    {
        public string FullName { get; set; }
        public int ID { get; set; }
        public string DateOfBirth { get; set; }
        public string Native { get; set; }
        public string ClassName { get; set; }
        public int PhoneNum { get; set; }

        public Student()
        {

        }
        public Student(int id)
        {
            this.ID = id;
        }
        
        public Student(string fullname,int id,string date,string native,string classname, int phonenum)
        {
            this.FullName = fullname;
            this.ID = id;
            this.DateOfBirth = date;
            this.Native = native;
            this.ClassName = classname;
            this.PhoneNum = phonenum;
        }


        public int CompareTo([AllowNull] Student other)
        {
            if (this.ID>other.ID)
            {
                return 1;
            }

            else if (this.ID < other.ID)
            {
                return -1;
            }
            return 0;
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            if (format == null)
                format = "id";

            switch (format.ToUpper())
            {
                case "ID":
                    return $"id={this.ID} name={this.FullName} date={this.DateOfBirth} native={this.Native} " +
                $"class={this.ClassName} phonenum={this.PhoneNum}";
                case "CLASS":
                    return $"class={this.ClassName} name={this.FullName} date={this.DateOfBirth} native={this.Native} " +
                $"phonenum={this.PhoneNum} id ={ this.ID}";
                default:
                    throw new FormatException("not allow!!!");
            }
        }

        public override string ToString()
        {
            return $"name={this.FullName} id={this.ID} date={this.DateOfBirth} native={this.Native} " +
                $"class={this.ClassName} phonenum={this.PhoneNum}";
        }

        public string ToString(string format) => this.ToString(format, null);

        public bool Equals([AllowNull] Student other)
        {
            if(other == null) return false;
            return (this.ID.Equals(other.ID));
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Student objAsStudent = obj as Student;
            if (objAsStudent == null) return false;
            else return Equals(objAsStudent);
        }

        public override int GetHashCode()
        {
            return this.ID;
        }
    }
}
