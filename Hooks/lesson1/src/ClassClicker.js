import { React, Component } from "react";

class ClassClicker extends Component {
  constructor(props) {
    super(props);
    this.state = {
      count: 0,
    };
  }

  handleClick = () => {
    this.setState({ count: this.state.count + 1 });
  };

  render() {
    return (
      <div>
        <button
          onClick={this.handleClick}
          className="group relative h-12 w-48 overflow-hidden rounded-2xl bg-[#00df9a] text-lg font-bold text-white"
        >
          Click me
          <div className="absolute inset-0 h-full w-full scale-0 rounded-2xl transition-all duration-300 group-hover:scale-100 group-hover:bg-white/30"></div>
        </button>

        <div>
          <p>Clicked {this.state.count} times</p>
        </div>
      </div>
    );
  }
}

export default ClassClicker;
