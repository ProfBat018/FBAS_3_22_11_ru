import React from "react";

export default class ClassEffect extends React.Component {
  constructor(props) {
    super(props);
    this.state = {
      count: 0,
      username: `John Doe`,
    };
  }

  handleClick() {
    this.setState({ count: this.state.count + 1 });
  }

  componentDidMount() {
    console.log(`Component mounted`);
  }

  componentDidUpdate() {
    console.log(`Component updated ${this.state.count}`);
  }

  componentWillUnmount() {
    console.log(`Component will unmount`);
  }

  render() {
    const elem = (
      <div>
        <button
          onClick={this.handleClick.bind(this)}
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

    return elem;
  }
}

