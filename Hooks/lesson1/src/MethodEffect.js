import React from "react";
import { useEffect, useState } from "react";

export default function MethodEffect() {
  const [count, setCount] = useState(0);

  function handleClick() {
    setCount(count + 1);
    console.log(`Clicked ${count} times`);
  }

  useEffect(() => {
    console.log(`Component mounted`);
  }, []);

  // Воторой аргумент - массив зависимостей, на основе которых будет вызываться useEffect
  useEffect(() => {
    console.log(`Component updated ${count}`);
  }, [count]);
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
