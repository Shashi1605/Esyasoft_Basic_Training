import { createContext, useState } from 'react'
import reactLogo from './assets/react.svg'
import viteLogo from '/vite.svg'
import './App.css'
import UseContextComponent from './Components/UseContextComponent';
import UseReducer from './Components/UseReducer';
import ApiCallApp from './Components/ApiCallApp';

const Context = createContext(null);
export {Context};

function App() {

  
  const [theme, setTheme] = useState("Light");
  const [count, setCount] = useState(0);
 
  return (
    <Context.Provider value={{

      theme: "Dark",
      setTheme : setTheme,
      count : count,
      setCount: setCount

    }}>
      <UseContextComponent />
      <UseReducer />
      <ApiCallApp />
    </Context.Provider>
  )
}

export default App
