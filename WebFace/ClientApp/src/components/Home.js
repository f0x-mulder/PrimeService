import React, { Component } from 'react';

export class Home extends Component {
  displayName = Home.name
  constructor(props) {
        super(props);
        this.state = { num: 5, isPrime: true };
        fetch('api/prime/5')
            .then(response => response.json())
            .then(data => {
                this.setState({ isPrime: data });
            });
    }
  render() {
    return (
        <div>
            <input type="number" placeholder="¬ведите число" value="2">
            
        </div>
    );
  }
}
