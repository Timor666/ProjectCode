using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LitJson;
using System.IO;

namespace JSON
{
    class Program
    {
        static void Main(string[] args)
        {
            #region json生成测试
            //Book b1 = new Book("崛起", 199);
            //Book b2 = new Book("提莫队长", 123);
            //Student s1 = new Student(001, "小明", false, new Book[] { b1, b2 });
            //Student s2 = new Student(002, "小红", true, new Book[] { b1, b1, b2 });

            //Student[] sArray = new Student[] { s1, s2 };
            //string json = JsonMapper.ToJson(sArray);
            //Console.WriteLine(json);
            #endregion
            #region Json读取测试
            string json = File.ReadAllText(@"D:\VSProject\JSON\JSON\Json.json");
         //   Student[] sArray = JsonMapper.ToObject<Student[]>(json);  //使用数组和list一样的结果

            List<Student> sArray = JsonMapper.ToObject<List<Student>>(json);

            foreach (Student st in sArray)
            {
                Console.Write(st.index + "-----------" + st.sex.ToString());
                foreach (Book b in st.books)
                {
                    Console.Write("-----------" +b.bookName + "-----------"+ b.prise);
                }
                Console.WriteLine();
            }

            #endregion
            Console.ReadKey();
        }
    }



    [Serializable]
    public class Student
    {
        public int index;
        public string studentName;
        public bool sex;
        public Book[] books;

        public Student()
        {
        }

        public Student(int index, string studentName, bool sex, Book[] books)
        {
            this.index = index;
            this.studentName = studentName;
            this.sex = sex;
            this.books = books;
        }
    }

    [Serializable]
    public class Book
    {
        public string bookName;
        public int prise;

        public Book()   //有时不写默认构造 会报错
        {
        }

        public Book(string bookName, int prise)
        {
            this.bookName = bookName;
            this.prise = prise;
        }
    }
}
