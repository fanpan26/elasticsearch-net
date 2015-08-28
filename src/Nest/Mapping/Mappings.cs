using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace Nest
{
	[JsonConverter(typeof(VerbatimDictionaryKeysJsonConverter))]
	public interface IMappings : IHasADictionary { }
	public class Mappings : IsADictionary<TypeName, ITypeMapping>, IMappings
	{
		public Mappings() : base() { }
		public Mappings(IDictionary<TypeName, ITypeMapping> container) : base(container) { }
		public Mappings(Dictionary<TypeName, ITypeMapping> container)
			: base(container.Select(kv => kv).ToDictionary(kv => kv.Key, kv => kv.Value))
		{ }

		/// <summary>
		/// Add any setting to the index
		/// </summary>
		public void Add(TypeName type, ITypeMapping mapping) => BackingDictionary.Add(type, mapping);

	}
	
	public class MappingsDescriptor : HasADictionary<MappingsDescriptor, TypeName, ITypeMapping>, IMappings
	{
		public MappingsDescriptor Map<T>(Func<TypeMappingDescriptor<T>, ITypeMapping> selector) where T : class
		{
			this.BackingDictionary.Add(typeof(T), selector?.Invoke(new TypeMappingDescriptor<T>()));
			return this;
		}
	}

}