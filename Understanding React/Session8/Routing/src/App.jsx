import NavBar from "./Components/NavBar";
import AboutPage from "./pages/AboutPage";
import Api from "./pages/Api";
import HomePage from "./pages/HomePage";
import { BrowserRouter, Route, Routes } from "react-router-dom";

function App() {
  return (
    <>
      <BrowserRouter>
      <NavBar />
        <Routes>
          <Route path="/" element={<HomePage />} />
          <Route path="/about" element={<AboutPage />} />
          <Route path="/api" element= {<Api />} />
        </Routes>
      </BrowserRouter>
    </>
  );
}

export default App;
