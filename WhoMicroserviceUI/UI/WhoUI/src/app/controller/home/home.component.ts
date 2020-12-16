import { Component, OnInit } from '@angular/core';
import {DataFetchService} from '../../services/data-fetch.service';
import {CountryModel} from '../../Model/CountryModel';
import { MatTableDataSource } from '@angular/material';


@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
  
})
export class HomeComponent implements OnInit {
 
   countryObj : CountryModel [] = [] ;
   dataSource :any;
   displayedColumns: string[] = ['flag','country', 'cases', 'countryInfo', 'todayCases','deaths','todayDeaths','recovered','active','critical','casesPerOneMillion','deathsPerOneMillion'];
   //
  constructor(private servObj:DataFetchService) {

   }

  ngOnInit() {
    this.fetchData();
    
  }

  fetchData(){
    this.servObj.getdata().subscribe((response)=>{
     console.log(response);
    this.dataSource = response;
    this.countryObj=response;
    }
    )
  }
  applyFilter(event: Event){
    const filterValue = (event.target as HTMLInputElement).value;
    this.dataSource = new MatTableDataSource(this.countryObj);
    this.dataSource.filter = filterValue.trim().toLowerCase();

  }

}
