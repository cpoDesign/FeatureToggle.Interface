namespace FeatureToggle.Interface
{
    public interface IFeature
    {
        /// <summary>
        /// Boolean result to determine if feature is enabled or not
        /// </summary>
        /// <param name="feature">Name of the feature</param>
        /// <returns>Boolean result</returns>
        bool IsFeatureEnabled(string feature);

    }
}
