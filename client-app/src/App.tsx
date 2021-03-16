import React, { useEffect, useState } from 'react';
import logo from './logo.svg';
import './App.css';
import axios from 'axios';

function App() {
  const [events, setEvents] = useState([]);

  useEffect(() => {
    axios.get('http://localhost:5000/api/events').then(response => {
      console.log(response);
      setEvents(response.data);
    })
  }, []);

  return (
    <div className="App">
      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
        <ul>
          {events.map((event: any) => (
            <li key={event.id}>
              {event.title}
            </li>
          ))}
        </ul>
      </header>
    </div>
  );
}

export default App;
