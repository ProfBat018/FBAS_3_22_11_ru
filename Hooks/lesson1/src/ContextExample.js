import React from "react";
import { useContext } from "react";
import { ThemeContext } from "./App";

export default function ContextExample() {
  const theme = useContext(ThemeContext);

  return (
    <div className={theme}>
      <h1>Context Example</h1>
    </div>
  );
}
