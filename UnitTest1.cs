using UnitTest;
namespace CarApp_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAccelerate()
        {
            
            Car car = new Car(CarType.Audi, 0, DrivingMode.Stopped);

            
            car.Accelerate();

            
            Assert.AreEqual(25, car.Velocity);
        }

        [TestMethod]
        public void TestBrake()
        {
           
            Car car = new Car(CarType.BMW, 30, DrivingMode.Forward);

            car.Brake();

            
            Assert.AreEqual(15, car.Velocity);
        }

        [TestMethod]
        public void TestStop()
        {
            
            Car car = new Car(CarType.Mercedes, 20, DrivingMode.Reverse);

            
            car.Stop();

            
            Assert.IsTrue(car.IsStopped());
        }

        [TestMethod]
        public void TestAddCar()
        {
            
            CarStore store = new CarStore();
            Car car = new Car(CarType.Toyota, 40, DrivingMode.Forward);

           
            store.AddCar(car);

            
            Assert.AreEqual(1, store.Cars.Count);
            Assert.IsTrue(store.Cars.Contains(car));
        }

        [TestMethod]
        public void TestGetAllStoreCars()
        {
            
            List<Car> cars = new List<Car>
            {
                new Car(CarType.Honda, 50, DrivingMode.Stopped),
                new Car(CarType.Fiat, 60, DrivingMode.Reverse)
            };
            CarStore store = new CarStore(cars);

           
            List<Car> retrievedCars = store.GetAllStoreCars();

            
            Assert.AreEqual(cars.Count, retrievedCars.Count);
            Assert.IsTrue(retrievedCars.All(cars.Contains));
        }
    }
}