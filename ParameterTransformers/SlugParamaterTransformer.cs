namespace CityBreaks1.ParameterTransformers
{
    public class SlugParameterTransformer :
 IOutboundParameterTransformer
    {
        public string TransformOutbound(object value)
        {
            return value?.ToString().Replace(" ", "-");
        }
    }
}
