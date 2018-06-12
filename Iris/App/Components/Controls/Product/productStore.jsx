import { observable } from "mobx";

export class ProductStore {
    @observable name = "";
    @observable productId = "";
    @observable description = "";
    @observable pictureUrl = "";
    @observable price = "";
}