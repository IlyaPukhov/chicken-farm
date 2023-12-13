using ChickenFarm.Models;
using ChickenFarm.Notification;
using Microsoft.EntityFrameworkCore;

namespace ChickenFarm
{
    public class SingletonDatabase
    {
        private static SingletonDatabase? instance;
        private readonly ApplicationContext _dbContext;
        private List<IDatabaseObserver> _observers;

        private SingletonDatabase()
        {
            _observers = [];
            _dbContext = new ApplicationContext();
        }

        public static SingletonDatabase GetInstance()
        {
            instance ??= new SingletonDatabase();
            return instance;
        }

        public void AddObserver(IDatabaseObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IDatabaseObserver observer)
        {
            _observers.Remove(observer);
        }

        private void Notify(Chicken chicken)
        {
            foreach (var observer in _observers)
            {
                observer.UpdateNotify(chicken);
            }
        }

        public void AddEmployee(Employee employee)
        {
            _dbContext.Add(employee);
            _dbContext.SaveChanges();
        }

        public void RemoveEmployee(Employee employee)
        {
            _dbContext.Remove(employee);
            _dbContext.SaveChanges();
        }

        public void UpdateEmployee(Employee employee)
        {
            _dbContext.Update(employee);
            _dbContext.SaveChanges();
        }

        public void AddChicken(Chicken chicken)
        {
            _dbContext.Add(chicken);
            _dbContext.SaveChanges();

            Notify(chicken);
        }

        public void RemoveChicken(Chicken chicken)
        {
            _dbContext.Remove(chicken);
            _dbContext.SaveChanges();

            Notify(chicken);
        }

        public void UpdateChicken(Chicken chicken)
        {
            _dbContext.Update(chicken);
            _dbContext.SaveChanges();

            Notify(chicken);
        }

        public void AddBreed(Breed breed)
        {
            _dbContext.Add(breed);
            _dbContext.SaveChanges();
        }

        public void RemoveBreed(Breed breed)
        {
            _dbContext.Remove(breed);
            _dbContext.SaveChanges();
        }

        public void UpdateBreed(Breed breed)
        {
            _dbContext.Update(breed);
            _dbContext.SaveChanges();
        }

        public void AddCell(Cell cell)
        {
            _dbContext.Add(cell);
            _dbContext.SaveChanges();
        }

        public void RemoveCell(Cell cell)
        {
            _dbContext.Remove(cell);
            _dbContext.SaveChanges();
        }

        public void UpdateCell(Cell cell)
        {
            _dbContext.Update(cell);
            _dbContext.SaveChanges();
        }
    }
}
