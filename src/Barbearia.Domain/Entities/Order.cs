using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace Barbearia.Domain.Entities;

public class Order
{
    public int OrderId { get; set; }
    public int Number { get; set; }
    public int Status { get; set; }
    public DateTime BuyDate { get; set; }
    public int PersonId { get; set; }
    public Person? Person { get; set; }
    public Payment? Payment { get; set; }

    //no banco, order está com a id de payment, mas não é necessário,
    //pois payment já tem o id de order. Além disso, a relação é opcional.

    void IsNumberValid()
    {
        if (Number <= 0) throw new Exception("O Número tem que ser positivo e diferente de 0");

        //handler tem que testar também se não existe número repetido no banco
    }

    void IsCustomerValid()
    {
        if (Person == null) throw new Exception("Order tem que ter um Customer");
    }

    void IsDataValid()
    {
        try
        {
            DateTime dataParseada = BuyDate;
        }
        catch (FormatException)
        {
            throw new Exception("A data tem que ser válida");
        }
    }

    bool IsValid()
    {
        IsNumberValid();

        IsCustomerValid();

        IsDataValid();

        return true;
    }


}
