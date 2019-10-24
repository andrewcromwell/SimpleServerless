import React from 'react';
import logo from './logo.svg';
import './App.css';
import { basename } from 'path';
import axios from 'axios';

class App extends React.Component {
  constructor(props) {
    super(props);
    this.state = {
      germanWords: []
    };
  }

  componentDidMount() {
    axios.get('https://germanword20191019012406.azurewebsites.net/api/getgermanwords')
      .then(response => {
        console.log(response);
        const germanWords = response.data;
        this.setState({ germanWords });
      })
      .catch(function (error) {
        console.log(error);
      })
      .finally(function () {
        // always executed
      });
  }

  render() {
    return (
      <div className="App">
          <table>
            <thead>
              <tr>
                <th>word</th>
                <th>part of speech</th>
              </tr>
            </thead>
            <tbody>
              {
                this.state.germanWords.map((word) =>
                  <tr key={word.id}>
                    <td>{word.word}</td>
                    <td>{word.partOfSpeech}</td>
                  </tr>
                )
              }
            </tbody>
          </table>
        </div>
    );
  }

}

export default App;
