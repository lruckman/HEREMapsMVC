using System.Collections.Generic;

namespace HEREMapsMVC.Models
{
    public interface IParameterCollection : IList<string>
    {
        string Prefix { get; }
    }

    public class ParameterCollection : List<string>, IParameterCollection
    {
        public string Prefix { get; }

        public ParameterCollection(string prefix)
        {
            Prefix = prefix;
        }

        public override string ToString()
        {
            var parameters = new List<string>();
            for (var i = 0; i < Count; i++)
            {
                parameters.Add($"{Prefix}{i}={this[i]}");
            }

            return string.Join("&", parameters);
        }
    }
}