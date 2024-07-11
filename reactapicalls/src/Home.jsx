import React, { Component } from "react";
import { Outlet } from "react-router-dom";
import Navbar from "./Navbar";

export default class Home extends Component {
  render() {
    return (
      <div>
        <header>
          <Navbar />
        </header>
        <main>
          <Outlet /> {/* Сюда будут рендериться дочерние компоненты */}
        </main>
      </div>
    );
  }
}
