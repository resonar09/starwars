import { Component, OnInit } from '@angular/core';
import { StarWarsService } from '../services/starwars.service';

@Component({
  selector: 'app-tab1',
  templateUrl: 'tab1.page.html',
  styleUrls: ['tab1.page.scss']
})
export class Tab1Page implements OnInit{
characters: any = [];
  constructor(private starWarsService: StarWarsService) {
  }
  ngOnInit() {
    this.getCharacters();
  }
    getCharacters() {
      this.starWarsService.getCharacters().subscribe(
         data => { this.characters = data; },
         err => console.error(err),
         () => console.log(this.characters)
        );
      }
}
