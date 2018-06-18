import React from "react";
import "isomorphic-fetch";
import { observer } from "mobx-react";
import { observable } from "mobx";

@observer
class Home extends React.Component {

    constructor(props) {
        super(props);
    }

    render() {
        return (
            <div className="container">
                Hello World!
            </div>

        );
    }
}

export default Home;