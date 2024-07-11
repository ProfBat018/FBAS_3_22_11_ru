import "./index.css";
import React from "react";
import ReactDOM from "react-dom/client";
import Routes from "./Routes";
import { createBrowserRouter, RouterProvider } from "react-router-dom";
import { QueryClient, QueryClientProvider } from "react-query";

const router = createBrowserRouter(Routes);
const client = new QueryClient();

const root = ReactDOM.createRoot(document.getElementById("root"));
root.render(
  <QueryClientProvider client={client}>
    <RouterProvider router={router} />
  </QueryClientProvider>
);
