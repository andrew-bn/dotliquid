namespace DotLiquid.Util
{
	public delegate TOutput Converter<in TInput, out TOutput>(TInput input);
}