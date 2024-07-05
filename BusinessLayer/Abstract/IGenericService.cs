using System.Linq.Expressions;

namespace BusinessLayer.Abstract
{
	public interface IGenericService<T>
	{
		void Tadd(T t);
		void TDelete(T t);
		void TUpdate(T t);
		List<T> TGetList();
		T TGetByID(int id);
		//List<T> TGetByFilterl(Expression<Func<T,bool>>filter);
	}
}
