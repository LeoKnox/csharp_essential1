using System;

namespace spells
{
  public class Fire
  {
    public string Name { get; }
    public string Caster { get; set; }
    public int Damage { get; }
    
    public void CastSpell(int amount, string effect)
    {
    }
  }
  
  pubic WizardCast(string name, int slots)
  {
    this.Caster = name;
    this.Damage = slots;
  }
  
  var Vaughn = new Fire("<name>", 10);
  Console.WriteLine($"{Fire.Caster} casts {Fire.Name} for {Fire.Damage}
}
