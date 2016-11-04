```cs
        [Test]
        public void ExecuteCountUpCommand()
        {
            // CountUpCommandが呼び出された場合のテストを実装しなさい
            var counter = new Mock<ICounter>();
            var viewModel = new CounterPageViewModel(counter.Object);
            var command = viewModel.CountUpCommand;
            Assert.IsNotNull(command);
            Assert.IsTrue(command.CanExecute());

            command.Execute();

            counter.Verify(m => m.CountUp(), Times.Once);
        }

        [Test]
        public void UpdatedCounterValue()
        {
            // ICounterのValueがインクリメントされた場合のテストを記述しなさい
            var counter = new Mock<ICounter>();
            var viewModel = new CounterPageViewModel(counter.Object);

            counter
                .SetupGet(m => m.Value)
                .Returns(100);
            counter.Raise(m => m.PropertyChanged += null, new PropertyChangedEventArgs("Value"));

            Assert.AreEqual(100, viewModel.Value);
        }
```
