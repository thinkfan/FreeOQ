using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace FreeQuant.Services
{
	public class ServiceList : ICollection
	{
		private SortedList<string, IService> servicesByName; 
		private SortedList<byte, IService> servicesById; 
		private List<IService> services; 

		public int Count
		{
			get
			{
				return this.services.Count; 
			}
		}

		public bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		public object SyncRoot
		{
			get
			{
				return null;
			}
		}

		public IService this[string name]
		{
			get
			{
				IService service;
				if (this.servicesByName.TryGetValue(name, out service))
				{
					return service;
				}
				return null;
			}
		}

		public IService this[byte id]
		{
			get
			{
				IService service;
				if (this.servicesById.TryGetValue(id, out service))
				{
					return service;
				}
				return null;
			}
		}

		internal ServiceList()
		{
			this.servicesByName = new SortedList<string, IService>();
			this.servicesById = new SortedList<byte, IService>();
			this.services = new List<IService>();
		}

		public void CopyTo(Array array, int index)
		{
			this.services.ToArray().CopyTo(array, index);
		}

		public IEnumerator GetEnumerator()
		{
			return this.services.GetEnumerator();
		}

		internal void Add(IService service)
		{
			this.servicesByName.Add(service.Name, service);
			this.servicesById.Add(service.Id, service);
			this.Refresh();
		}

		private void Refresh()
		{
			this.services.Clear();
			foreach (var service in this.servicesByName.Values)
				this.services.Add(service);
		}
	}
}
