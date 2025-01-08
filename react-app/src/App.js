import logo from './logo.svg';
import './App.css';
import store from './actions/store';
import { Provider } from 'react-redux';
import EAttendees from './components/EAttendees';

function App() {
  return (
    <Provider store={store}>
      <EAttendees />
    </Provider>
  );
}

export default App;
