import { Component, OnInit } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { Test } from '../models/test';
import { NgFor } from '@angular/common';
import { TestService } from '../services/test.service';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, NgFor],
  providers: [TestService],
  templateUrl: './app.component.html',
  styleUrl: './app.component.sass'
})
export class AppComponent implements OnInit {

  tests : Test[] = [];
  title = 'onlinestore';

  constructor(private testService: TestService){

  }

  ngOnInit(): void {
    this.testService.getAll().subscribe(data => {
      this.tests = data;
    })
  }

  onButtonClick() : void {
    let data = new Test();
    data.testData = "Add data";
    this.testService.add(data).subscribe(data => {
      console.log("TestData is saved");
    });
  }
}
