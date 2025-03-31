namespace Bespoke.Core.Builders
{
    public class CustomSettingsBuilder
    {
        // Store customization actions by settings type.
        private readonly Dictionary<Type, Delegate> _customizations = new Dictionary<Type, Delegate>();

        /// <summary>
        /// Registers a customization delegate for the settings type T.
        /// </summary>
        public CustomSettingsBuilder Settings<T>(Action<T> configureOptions) where T : class
        {
            if (_customizations.TryGetValue(typeof(T), out var existing))
            {
                // Combine with any previously registered delegate.
                _customizations[typeof(T)] = (Action<T>)existing + configureOptions;
            }
            else
            {
                _customizations[typeof(T)] = configureOptions;
            }
            return this;
        }

        /// <summary>
        /// Tries to retrieve a customization delegate for T.
        /// </summary>
        public bool TryGetCustomization<T>(out Action<T> customization) where T : class
        {
            if (_customizations.TryGetValue(typeof(T), out var del))
            {
                customization = del as Action<T>;
                return true;
            }
            customization = null;
            return false;
        }
    }
}