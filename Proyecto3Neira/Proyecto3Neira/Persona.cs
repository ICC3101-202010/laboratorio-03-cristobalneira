using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Persona
{
    protected string name;
    protected string surname;
    protected string bday;
    protected string nation;
    protected string sex;
    private int age;
    protected string rut;
    public Persona(string name,string surname,string bday,string nation, string sex, int age, string rut)
    {
        this.name = name;
        this.surname = surname;
        this.bday = bday;
        this.nation = nation;
        this.sex = sex;
        this.age = age;
        this.rut = rut;
    }
    public virtual void Info()
    {
        Console.WriteLine("Name: " + name + ", Surname: "+surname+", Birthday: " + bday + ", Nation from: "+nation+", Sex: " + sex + ", Age: "+age+", RUT: "+rut + ".");
    }
    public string GetName()
    {
        return name+ " " + surname;
    }

    
}