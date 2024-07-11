import React from "react";
import { useState } from "react";

export default function FunctionalClicker() {
  const [count, setCount] = useState(0);

  function handleClick() {
    setCount(count + 1);
  }

  return (
    <div>
      <button
        onClick={handleClick}
        className="group relative h-12 w-48 overflow-hidden rounded-2xl bg-[#00df9a] text-lg font-bold text-white"
      >
        Click me
        <div className="absolute inset-0 h-full w-full scale-0 rounded-2xl transition-all duration-300 group-hover:scale-100 group-hover:bg-white/30"></div>
      </button>

      <div>
        <p>Clicked {count} times</p>
      </div>
    </div>
  );
}
