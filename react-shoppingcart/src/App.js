import logo from './logo.svg';
import './App.css';

function App() {
  return (
    <div className="App">
      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />

        <shopping-select software-unit-price="299"
                  option-unit-price="99"
                  module-unit-price="79"
                  training-unit-price="75" />

      </header>
    </div>
  );
}

export default App;
