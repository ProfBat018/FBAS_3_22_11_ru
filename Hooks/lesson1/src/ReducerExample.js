import { useReducer } from "react";

function ReducerExample(state, action) {
  if (action.type === "incremented_age") {
    return {
      age: state.age + 1,
    };
  } else if (action.type === "decremented_age") {
    return {
      age: state.age - 1,
    };
  }
  throw Error("Unknown action.");
}

export default function Counter() {
  const [state, setReducer] = useReducer(reducer, { age: 42 });
  cosnt[(count, setCount)] = useState(0);

  return (
    <div>
      <button
        onClick={() => {
          setReducer({ type: "incremented_age" });
        }}
      >
        Increment age
      </button>
      <button
        onClick={() => {
          setReducer({ type: "decremented_age" });
        }}
      >
        Decrement age
      </button>

      <p>Hello! You are {state.age}.</p>
    </div>
  );
}
