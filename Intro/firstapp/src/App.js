import logo from "./logo.svg";
import Navbar from "./navbar";
import { useState } from "react";

import Home from "./home";
import About from "./about";
import Contact from "./contact";

import "./App.css";

import GreenBtn from "./greenbtn";

function App() {
  const [page, setPage] = useState("home"); // hook, который отслеживает состояние объекта

  function goToHome() {
    setPage("home");
  }

  function goToAbout() {
    setPage("about");
  }

  function goToContact() {
    setPage("contact");
  }

  return (
    <div className="App">
      <header className="App-header">
        <Navbar
          goToHome={goToHome}
          goToAbout={goToAbout}
          goToContact={goToContact}
        />
      </header>

      <main>
        {page === "home" && (
          <h1>
            <Home />
          </h1>
        )}
        {page === "about" && (
          <h1>
            <About />
          </h1>
        )}
        {page === "contact" && (
          <h1>
            <Contact />
          </h1>
        )}
      </main>
    </div>
  );
}

export default App;
