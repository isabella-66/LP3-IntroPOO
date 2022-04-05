public class Quadrado 
{

    //field
    public double Lado { get; set; } //então não precisa dos métodos get e set, lado fica em maiúsculo e sem ; no final - propriedade

    //métodos contrutores
    public Quadrado(double Lado) { this.Lado = Lado; }

    //métodos (comuns)
    public double Area { get => Lado * Lado; }

    public double Perimetro { get => 4 * Lado; }
}