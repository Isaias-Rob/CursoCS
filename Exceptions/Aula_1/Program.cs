using Aula_1.Models;

static double Dividir(int x, int y){
    if(y == 0){
        //throw new ArithmeticException();
        throw new ClassException("Mensagem customizada de erro\n");
    }
    return (x/y);
}


int a = 100, b = 0;
double resultado = 0;
//ira gerar uma interrupção
try{
    resultado = Dividir(a,b);
    System.Console.WriteLine("{0} dividido por {1} = {2}",a,b,resultado);
} catch(DivideByZeroException exception){
    System.Console.WriteLine(exception.Message);
} catch(Exception exception){
    //System.Console.WriteLine("Exceção genérica");
    System.Console.WriteLine(exception.Message);
    throw;
} finally{
    System.Console.WriteLine("Dividindo ou não, aqui estou");
}


