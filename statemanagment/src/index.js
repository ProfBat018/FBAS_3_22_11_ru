import React from "react";
import ReactDOM from "react-dom/client";
import "./index.css";
import { createBrowserRouter, RouterProvider } from "react-router-dom";
import Routes from "./Routes";
import { store } from "./Store";
import { Provider } from "react-redux";

const root = ReactDOM.createRoot(document.getElementById("root"));

const router = createBrowserRouter(Routes);

root.render(
  <React.StrictMode>
    <Provider store={store}>
      <RouterProvider router={router} />
    </Provider>
  </React.StrictMode>
);
