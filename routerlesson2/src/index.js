import "./index.css";
import React from "react";
import ReactDOM from "react-dom/client";
import Routes from "./Routes";
import { createBrowserRouter, RouterProvider } from "react-router-dom";

const router = createBrowserRouter(Routes);

const root = ReactDOM.createRoot(document.getElementById("root"));
root.render(<RouterProvider router={router} />);
