import { Input, OnInit, OnDestroy } from "@angular/core";
import { Component } from "@angular/core";
import { GeographicCoordinates } from "src/app/models/geographic-coordinates-model";
import { GeographicDataService } from "src/services/geographic-data/geographic-data-service";
import { takeUntil, map, take, catchError } from 'rxjs/operators';


@Component({
    selector: 'cameras-field',
    templateUrl: './cameras-component.html'
})

export class CamerasComponent implements OnInit {
    public firstFieldCoordinates: GeographicCoordinates;
    public secondFieldCoordinates: GeographicCoordinates;
    public thirdFieldCoordinates: GeographicCoordinates;
    public fourthFieldCoordinates: GeographicCoordinates;

    constructor(private geographicDataService: GeographicDataService) { }

    ngOnInit(): void {
        this.geographicDataService.getData().subscribe((x: GeographicCoordinates) => {
            if(x !== null){

            }
        }, err => console.log(err));
    }

    ngOnDestroy(): void {}

    public calculateCoordinates(geographicCoordinates: GeographicCoordinates) {
        
        if(geographicCoordinates.CameraNumber % 3){
            this.firstFieldCoordinates = geographicCoordinates;
        }else if(geographicCoordinates.CameraNumber % 5){
            //....
        }
    }

}