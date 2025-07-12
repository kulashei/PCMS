namespace CMS
{
    public class PropertyMapper
    {
        public static void CopyProperties(object source, object destination)
        {
            var sourceProperties = source.GetType().GetProperties();
            var destinationProperties = destination.GetType().GetProperties();

            foreach (var sourceProp in sourceProperties)
            {
                foreach (var destProp in destinationProperties)
                {
                    if (destProp.Name == sourceProp.Name && destProp.PropertyType == sourceProp.PropertyType)
                    {
                        destProp.SetValue(destination, sourceProp.GetValue(source));
                        break;
                    }
                }
            }
        }
    }
}
