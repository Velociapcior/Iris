import React from "react";
import "isomorphic-fetch";
import { observer } from "mobx-react";
import { observable } from "mobx";
import { Product } from "./Controls/Product/product.jsx";
import { ProductStore } from "./Controls/Product/productStore.jsx";

@observer
class Home extends React.Component {

    constructor(props) {
        super(props);

        this.onHandleDelete = this.onHandleDelete.bind(this);
    }

    @observable products = [];

    componentDidMount() {
        fetch("iris/home/GetNewListOfProducts")
            .then(response => response.json())
            .then(data => {
                this.saveDataToStore(data);
            });
    }

    saveDataToStore(data) {
        for (var index in data) {
            let productStore = new ProductStore;

            productStore.description = data[index].Description;
            productStore.name = data[index].Name;
            productStore.productId = data[index].ProductId;
            productStore.pictureUrl = data[index].PictureUrl;
            productStore.price = data[index].Price;

            this.products.push(productStore);
        }
    }

    onHandleDelete(productId) {
        var index = this.products.map((e) => { return e.productId }).indexOf(productId);

        fetch("iris/home/DeleteProductFromList",
            {
                body: JSON.stringify({productId: productId}),
                headers: {
                    'content-type': 'application/json'
                },
                method: "POST"
            }).then(response => response.json())
            .then(data => {
                if (data.success) {
                    this.products = this.products.filter(item => item !== this.products[index]);
                }
            });
    }

    render() {
        return (
            <div className="container">
                <section className="hero is-primary">
                    <div className="hero-body">
                        <div className="container">
                            <h1 className="title">
                                Lista produktów
                        </h1>
                        </div>
                    </div>
                </section>
                <section className="container">
                    <div className="columns is-multiline">
                        {
                            this.products.map(product => (
                                <div className="column is-half" key={product.productId}>
                                    <Product store={product} onClick={this.onHandleDelete} />
                                </div>
                            ))}
                    </div>
                </section>
            </div>

        );
    }
}

export default Home;