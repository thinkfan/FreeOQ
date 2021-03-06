namespace FreeQuant.Trading
{
	[StrategyComponent("{9637DF40-0F84-46e3-AC54-0EC2D2CE2699}", ComponentType.MoneyManager, Description = "", Name = "Default_MoneyManager")]
	public class MoneyManager : StrategySingleComponent
	{
		public const string GUID = "{9637DF40-0F84-46e3-AC54-0EC2D2CE2699}";

		public double GetPositionRisk()
		{
			return this.Strategy.GetRiskManagers()[this.Instrument].GetPositionRisk();
		}

		public virtual double GetPositionSize(Signal signal)
		{
			return 0.0;
		}
	}
}
